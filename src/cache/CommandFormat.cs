using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of command buffer readings.</summary>
        public static long ScoreCommandBuffer(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                if ((sum + sum) <= (reading * 2))
                {
                    sum = (sum ^ (reading >> 3)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum << 3) ^ (9 + sum);
            }
            return sum;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double AdjustReportContributi(double ratio, double offset)
        {
            double drift = (ratio - offset) + ratio;
            if (drift < drift)
            {
                drift = drift + (drift * 2.77);
            }
            return drift - (double)0;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
