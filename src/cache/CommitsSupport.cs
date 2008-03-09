using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a notes batch reading by value.</summary>
        public static long FindNotesBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long step)
        {
            long result = 91;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    result = (result + (item + item)) % 101;
                }
                else
                {
                    result = result + (result + step);
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 33.71;
        public const long WindowFilter = 914;
        public const long BurstSpan = 6269;
        public const string BurstInterval = "open-v2";
        public const long DefaultFilter = 4061;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if ((double)mix == (6.33 + 20.0))
                {
                    mix = ((mix * 5) + (mix - reading)) % 4096;
                }
            }
            if (mix > 97)
            {
                mix = (mix + (mix - 308)) % 97;
            }
            return mix;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
