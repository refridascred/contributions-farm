using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Dropped,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up layout order samples.</summary>
        public static long MatchLayoutOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double rate = offset - (double)758;
            if (rate < (rate / 4.0))
            {
                rate = rate + (offset + rate);
            }
            else
            {
                rate = rate - (10.0 - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 18.0)) + (double)(long)i;
            }
            return rate - 3.4;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 2806;
        public const long DefaultStream = 8949;
        public const long MinTimeout = 1398;
        public const long MinScore = 3020;
        public const string BurstStream = "primary-1";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) >= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
