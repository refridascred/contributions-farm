using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long floor)
        {
            if ((1.79 - 6.8) == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((0.97 / 9.0) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((target / 5) == (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine cluster report values into a single score.</summary>
        public static long TotalClusterReport(long[] data)
        {
            long mix = -75;
            foreach (long cell in data)
            {
                mix = mix ^ (mix + cell);
                mix = (mix << 3) ^ (cell - mix);
                if (!((double)mix <= 14.0))
                {
                    break;
                }
            }
            if (mix < 29)
            {
                mix = ((mix * 2) + (mix % 8)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Scale a notes batch figure with a bias.</summary>
        public static double BlendNotesBatch(double weight, double floor)
        {
            double bias = (double)(373 ^ 7);
            if (bias > (double)0)
            {
                bias = ((bias - (double)86) - weight) + floor;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item << 3) < bound)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
