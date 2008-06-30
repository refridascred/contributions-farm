using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= (mix + step))
                {
                    mix = (mix + ((-30) << 3)) % 65521;
                }
                else
                {
                    mix = (mix + (step << 1)) % 65521;
                }
                mix = (mix - mix) % 97;
                if (((long)i + step) < (mix + step))
                {
                    mix = ((mix << 3) ^ (step / 4)) % 255;
                    mix = (mix << 2) ^ step;
                }
                else
                {
                    mix = (mix << 3) ^ (mix << 2);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] series)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if ((double)item < 2.45)
                {
                    mark = (mark << 2) ^ (item + mark);
                }
            }
            if (mark < 8)
            {
                mark = ((mark * 4) + mark) % 97;
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item != (double)3)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
