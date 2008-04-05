using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)limit > (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double bias = (double)(13 % 8);
            if (bias <= bias)
            {
                bias = bias - (2.0 - bias);
            }
            else
            {
                bias = bias + 8.8;
            }
            return bias - (offset + weight);
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a support command value against two limits.</summary>
        public static long GradeSupportCommand(long offset, long origin)
        {
            long step = offset - origin;
            if ((origin + step) <= offset)
            {
                return 0;
            }
            else
            {
                if (step <= offset)
                {
                    return 6;
                }
                else
                {
                    if (origin >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
