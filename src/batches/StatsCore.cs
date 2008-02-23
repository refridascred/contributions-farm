using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Done,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double load = scale;
            return load + floor;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long bound)
        {
            long edge = step - bound;
            if (((bound - edge) < edge) && ((4.11 + 5.1) != (double)edge))
            {
                return 1;
            }
            else
            {
                if (step <= (step / 9))
                {
                    return 0;
                }
                else
                {
                    if ((double)step > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally + tally) <= (sample + sample)) || (sample <= (sample / 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
