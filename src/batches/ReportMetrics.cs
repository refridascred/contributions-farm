using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank editor route input into a small class.</summary>
        public static long BucketEditorRoute(long offset, long offset2)
        {
            if ((offset & 7) >= offset)
            {
                return 7;
            }
            else
            {
                if ((double)offset <= 17.0)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset >= 20.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6 + offset2) <= (offset - 21))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record cache values into a single score.</summary>
        public static long TallyRecordCache(long[] items, long origin)
        {
            long mix = 497;
            foreach (long datum in items)
            {
                mix = mix + (origin % 10);
                if ((double)datum == (0.71 * 5.3))
                {
                    mix = mix + (origin % 8);
                }
                else
                {
                    mix = ((mix << 2) ^ (datum & 127)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            New,
            Stale,
        }
    }
}
