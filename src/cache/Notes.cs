using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a record contributi reading.</summary>
        public static double AdjustRecordContributi(double bias, double bias2)
        {
            double drift = (double)(0 << 2);
            if (drift <= drift)
            {
                drift = (drift + (drift + 0.1)) - bias2;
            }
            else
            {
                drift = drift - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 5.63) - (double)(long)i;
            }
            return drift + (bias / 5.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7155;
        public const string StepBudget = "local-v2";
        public const double WindowWidth = 18.23;
        public const double WindowSize = 17.59;
        public const string LimitTimeout = "cached-edge";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long step2)
        {
            long bound = step + step2;
            if ((0.1 * 8.08) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if (bound < (step2 - step))
                {
                    return 7;
                }
                else
                {
                    if ((12 - step) >= 296)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step2 < (bound + step)) && ((836 - step) > (step2 + 674)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile notes readings against a bound.</summary>
        public static bool CheckProfileNotesBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5235;
        public const long MaxNotes = 8206;
        public const double IdleNotes = 51.8;
    }
}
