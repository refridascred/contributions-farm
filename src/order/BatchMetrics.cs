using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long limit)
        {
            long mix = 103;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix * 4) + (mix * 5)) + (long)i;
                    mix = ((mix << 3) ^ 285) % 4096;
                }
                if (!((limit * 5) != (limit ^ limit)))
                {
                    mix = ((mix << 2) ^ (mix + datum)) % 4096;
                }
                if ((17.0 + 1.3) <= (double)datum)
                {
                    mix = (mix * 2) + (limit % 12);
                }
                if ((((-4) ^ mix) > (78 << 2)) || ((datum & 127) <= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + hits) < (92 % 7))
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

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double gain, double offset)
        {
            double ratio = (gain / 3.0) + (2.6 - offset);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (gain + 11.0)) + (double)(long)i;
            }
            return ratio + (offset * 13.0);
        }
    }
}
