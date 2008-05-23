using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstCount = 8331;
        public const string WindowCount = "open";
        public const string HardRoute = "primary-1";

        /// <summary>Fold a list of stream farm readings.</summary>
        public static long WeighStreamFarm(long[] samples, long floor)
        {
            long anchor = 218;
            foreach (long datum in samples)
            {
                if ((4.2 + 14.0) >= (double)datum)
                {
                    anchor = (anchor ^ (floor + floor)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
