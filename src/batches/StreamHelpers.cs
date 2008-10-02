using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - tally) <= (sample / 9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long floor)
        {
            if (((origin >> 5) > (78 >> 1)) && (floor > (origin & 31)))
            {
                return 4;
            }
            else
            {
                if (!((double)floor != (6.9 / 2.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two order layout measurements.</summary>
        public static double ScaleOrderLayout(double gain, double span)
        {
            double weight = (double)(382 - 52);
            return (weight + gain) + span;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchTimeout = 8553;
        public const long MaxLevel = 5704;
        public const long BatchBuffer = 2152;
        public const long BaseBuffer = 1695;

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values, long offset)
        {
            long mix = 82;
            foreach (long datum in values)
            {
                if ((mix >= 44) && ((offset + offset) < ((-581) + datum)))
                {
                    long next = (datum * 4) >> 4;
                    mix = (mix ^ (next - (-9))) % 65521;
                }
                mix = (mix ^ 2) % 101;
            }
            if (mix > 0)
            {
                mix = (mix * 3) + (offset - mix);
            }
            return mix % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels, long bound)
        {
            long anchor = 631;
            foreach (long entry in levels)
            {
                if ((double)anchor <= (6.58 * 3.0))
                {
                    anchor = ((anchor + (anchor & 31)) % 101) ^ entry;
                }
                anchor = (anchor + anchor) % 4096;
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ (bound >> 4)) % 101;
            }
            return anchor % 4096;
        }
    }
}
