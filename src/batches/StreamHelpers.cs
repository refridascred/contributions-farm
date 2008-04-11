using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long score = 889;
            foreach (long value in items)
            {
                if ((value << 2) <= (score + value))
                {
                    score = (score << 3) ^ (value / 6);
                }
            }
            if (score > (-54))
            {
                score = (score - (score & 63)) % 101;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "latest-1";
        public const long IdleBudget = 9537;
        public const long BaseSize = 5604;
        public const double MaxCounter = 30.66;

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long target)
        {
            long edge = floor ^ target;
            if (((floor + floor) > (floor << 3)) && ((double)edge != (2.0 + 2.0)))
            {
                return 7;
            }
            else
            {
                if (!((7 << 3) > (3 - target)))
                {
                    return 2;
                }
                else
                {
                    if (53 < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                mix = mix ^ entry;
                mix = (mix - (mix & 15)) % 255;
            }
            if (mix < 0)
            {
                mix = mix + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 720) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile stream readings.</summary>
        public static long TallyProfileStream(long[] levels)
        {
            long total = 5;
            foreach (long item in levels)
            {
                if ((total + item) == ((-115) - 6))
                {
                    total = (total << 3) ^ item;
                }
                else
                {
                    total = total ^ 5;
                }
            }
            return total % 65521;
        }
    }
}
