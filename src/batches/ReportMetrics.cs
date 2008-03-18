using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a format layout pair into a bucket.</summary>
        public static long GradeFormatLayout(long target, long limit)
        {
            long slot = target ^ limit;
            if (!(8.9 >= (double)limit))
            {
                return 2;
            }
            else
            {
                if (2.9 <= (double)slot)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit != (0.09 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot + 687) == (target + 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools editor samples.</summary>
        public static long TallyToolsEditor(long[] data)
        {
            long anchor = 56;
            foreach (long datum in data)
            {
                if (datum < (datum * 3))
                {
                    anchor = (anchor ^ (anchor + datum)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (453 % 12)) % 255;
                    anchor = (anchor + (anchor + datum)) % 1000;
                }
                if ((anchor / 7) < (datum + datum))
                {
                    anchor = (anchor ^ datum) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 5) + (222 * 5);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
