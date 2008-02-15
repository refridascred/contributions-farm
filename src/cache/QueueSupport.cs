using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long floor)
        {
            long step = offset ^ floor;
            if (((step + floor) > (-21)) || ((step + 738) != (step + 434)))
            {
                return 0;
            }
            else
            {
                if ((1.95 / 4.0) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((step + floor) == (offset - offset))
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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - origin) % 101;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
