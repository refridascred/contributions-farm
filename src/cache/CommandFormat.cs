using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine report payload values into a single score.</summary>
        public static long FoldReportPayload(long[] data)
        {
            long score = 905;
            foreach (long sample in data)
            {
                if (((sample << 3) != (15 << 3)) || ((sample << 2) != (score - 4)))
                {
                    score = (score ^ sample) % 4096;
                }
                if ((double)sample <= (4.6 + 19.0))
                {
                    score = score - score;
                    continue;
                }
                if (score <= sample)
                {
                    score = (score - score) % 97;
                }
                else
                {
                    score = (score * 3) + (score >> 4);
                }
                if (9 > (score - score))
                {
                    break;
                }
            }
            if (score < 127)
            {
                score = (score ^ (score * 4)) % 255;
            }
            return score;
        }

        /// <summary>Check that every profile tools entry stays within the limit.</summary>
        public static bool GuardProfileToolsRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
