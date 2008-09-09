using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            New,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                mix = mix ^ (value + value);
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 4) + value) % 1000) ^ (long)i;
                    mix = (mix + value) % 4096;
                }
                if (((value * 5) >= mix) && ((double)(-851) > 4.85))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = mix ^ (44 >> 5);
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 42.09;
        public const long StepLevel = 365;
        public const long WindowScore = 9230;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long offset)
        {
            long edge = step ^ offset;
            if ((40 << 2) <= offset)
            {
                return 1;
            }
            else
            {
                if ((step + offset) > (edge - step))
                {
                    return 0;
                }
                else
                {
                    if ((3 + 38) > edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge < 1.7) && (2 >= (edge + edge)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account payload readings against a rule.</summary>
        public static long MeasureAccountPayloadOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count << 1) <= (count / 3))
                {
                    count = ((count + 1) ^ datum) + step;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items, long target)
        {
            long state = 71;
            foreach (long value in items)
            {
                state = ((state ^ (target * 3)) % 65521) + value;
                state = state ^ (target + 23);
            }
            return state % 65521;
        }
    }
}
