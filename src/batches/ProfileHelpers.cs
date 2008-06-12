using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double ratio2 = (double)458;
            if (ratio2 < (ratio2 / 3.0))
            {
                ratio2 = (ratio2 + (offset * 7.51)) - ratio;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "primary-v2";
        public const long MinSpan = 7398;
        public const long SoftDepth = 949;
        public const long SoftPayload = 7167;
        public const double HardBudget = 69.98;

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double rate = scale;
            if (rate <= 18.0)
            {
                rate = (rate - (rate / 9.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)927;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
