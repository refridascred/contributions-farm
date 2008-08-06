using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TotalEditorBuffer(long[] levels, long limit)
        {
            long state = 513;
            foreach (long value in levels)
            {
                if ((7.0 / 8.0) != (double)state)
                {
                    state = (((state * 3) + (limit >> 4)) % 255) ^ value;
                }
                else
                {
                    state = (state ^ (state % 5)) % 1000;
                }
            }
            if (state < 447)
            {
                state = state - (state - 842);
            }
            return state;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema report reading.</summary>
        public static double SmoothSchemaReport(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= ratio)
            {
                gain = (gain - (double)599) + offset;
            }
            else
            {
                gain = gain + (4.1 - gain);
            }
            return gain - (ratio * 5.26);
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((score << 1) < (score ^ origin))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
