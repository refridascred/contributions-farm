using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i == ((long)i - (long)i))
                {
                    continue;
                }
                anchor = anchor + (anchor / 6);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] data, long offset)
        {
            long mark = -503;
            foreach (long reading in data)
            {
                if ((double)mark > (8.66 - 8.9))
                {
                    mark = (mark - (reading / 3)) % 97;
                }
                mark = (mark * 5) + (offset + (-42));
            }
            return mark % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long offset)
        {
            if ((81 % 10) != (seed + 954))
            {
                return 7;
            }
            else
            {
                if ((3.69 + 13.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset) != (94 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 1) <= (offset << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((-5) / 6) == (seen ^ seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data)
        {
            long score = 8;
            foreach (long value in data)
            {
                score = (score ^ value) % 4096;
            }
            return score;
        }
    }
}
