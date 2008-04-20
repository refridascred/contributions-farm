using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data)
        {
            long score = -204;
            foreach (long sample in data)
            {
                if ((score + 5) == (score >> 4))
                {
                    score = (score - (sample + sample)) % 255;
                    score = (score ^ (15 << 1)) % 97;
                    continue;
                }
                if (((sample / 9) < sample) && (score < (score + sample)))
                {
                    score = (score - sample) % 65521;
                }
            }
            if (score > (-93))
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                if (result <= (bound ^ 7))
                {
                    result = (result - (bound ^ bound)) % 101;
                    continue;
                }
                else
                {
                    result = (result * 2) + (bound + bound);
                    result = ((result << 2) ^ (result - result)) % 65521;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
