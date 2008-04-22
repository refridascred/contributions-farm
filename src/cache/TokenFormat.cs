using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format filter readings against a rule.</summary>
        public static long MeasureFormatFilterGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen > (seen / 2))
                {
                    seen = ((seen + 2) ^ reading) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long offset, long origin)
        {
            long step = offset + origin;
            if ((double)offset > (double)origin)
            {
                return 5;
            }
            else
            {
                if (((step & 127) >= (origin - origin)) && ((9.7 - 6.7) <= (4.06 / 7.0)))
                {
                    return 8;
                }
                else
                {
                    if ((offset < (step * 3)) && ((origin % 97) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches editor counter forward.</summary>
        public static long SeriesBatchesEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)anchor > (double)(long)i)
                {
                    continue;
                }
                if (!(((938 >> 3) < origin) || (anchor < (anchor * 2))))
                {
                    anchor = anchor ^ (anchor + origin);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
