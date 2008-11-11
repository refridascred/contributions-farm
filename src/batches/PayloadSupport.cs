using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account notes values into a single score.</summary>
        public static long ScoreAccountNotes(long[] data)
        {
            long total = 990;
            foreach (long reading in data)
            {
                if ((double)total > (9.13 / 4.0))
                {
                    total = total - 3;
                    break;
                }
                if (24 >= reading)
                {
                    total = ((total * 4) + total) % 101;
                }
                else
                {
                    total = (total ^ (total >> 2)) % 4096;
                }
            }
            if (total > 1)
            {
                total = ((total << 3) ^ (total >> 3)) % 97;
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long limit, long target)
        {
            if ((target & 7) == (68 ^ 47))
            {
                return 5;
            }
            else
            {
                if ((target + target) > (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 + (-6)) <= (limit - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long MeasureStreamRecordMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (3.9 - 6.3))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
