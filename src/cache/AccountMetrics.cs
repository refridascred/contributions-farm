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

        /// <summary>Validate notes graph readings against a bound.</summary>
        public static bool VerifyNotesGraphBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
