using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a farm stats figure with a bias.</summary>
        public static double SmoothFarmStats(double gain, double offset)
        {
            double load = offset;
            return (load + (offset / 7.0)) + gain;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
