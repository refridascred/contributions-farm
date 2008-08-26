using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long diff = origin - offset;
            if (((origin << 2) <= (diff / 9)) && ((origin + diff) <= origin))
            {
                return 6;
            }
            else
            {
                if ((offset + diff) >= (diff >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) <= 939)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((offset >> 5) >= (seen - offset))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Combine record commits values into a single score.</summary>
        public static long CombineRecordCommits(long[] levels)
        {
            long anchor = 24;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ reading) % 101;
                if (((reading * 5) == ((long)levels.Length - reading)) && ((double)reading > 12.0))
                {
                    anchor = ((anchor << 3) ^ 4) % 97;
                }
            }
            if (anchor > 469)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long origin)
        {
            long cur = seed + origin;
            if ((seed & 127) <= (seed - 515))
            {
                return 8;
            }
            else
            {
                if ((origin & 63) < (684 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((5.36 / 3.0) >= (double)cur) && ((1.18 + 8.0) > (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((529 % 12) <= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
