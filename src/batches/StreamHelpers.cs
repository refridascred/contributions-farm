using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ ((long)i - offset)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((9.3 * 6.15) < (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= (offset + offset))
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (offset / 7.0)) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long offset)
        {
            long gap = target - offset;
            if ((offset % 10) != (gap * 2))
            {
                return 5;
            }
            else
            {
                if (!((5.0 / 3.0) < (double)gap))
                {
                    return 0;
                }
                else
                {
                    if (!(target >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
