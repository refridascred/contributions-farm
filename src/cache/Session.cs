using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (17.0 - 15.0))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings)
        {
            long total = 3;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (((total << 3) ^ entry) % 4096) + (long)i;
                }
                total = total ^ (total * 3);
                total = total - (entry >> 3);
            }
            return total % 97;
        }
    }
}
