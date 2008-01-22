using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a stream already counter forward.</summary>
        public static long RollStreamAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate batch report samples.</summary>
        public static long ScoreBatchReport(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if (((reading + mix) <= ((long)levels.Length ^ mix)) || (reading <= (69 + mix)))
                {
                    mix = (mix + (reading * 4)) % 101;
                }
                else
                {
                    mix = (mix - (mix ^ 9)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = mix - 8;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen ^ 58) != (target << 3))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long seed)
        {
            long bound = step + seed;
            if ((step ^ bound) > seed)
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (14.0 * 1.54))
                {
                    return 4;
                }
                else
                {
                    if ((step >> 5) <= (step + 353))
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.0 <= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total - 4) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count token session pairs that satisfy a relation.</summary>
        public static long OverlapTokenSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
