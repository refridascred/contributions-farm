using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 4288;
        public const double DefaultInterval = 22.0;
        public const long BurstBuffer = 2147;

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long total = -3;
            foreach (long sample in data)
            {
                total = ((total * 5) + (total % 2)) % 97;
                if ((sample ^ total) < (44 & 15))
                {
                    total = total + ((long)data.Length + sample);
                }
                if ((double)sample <= (10.0 * 4.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long limit, long limit2)
        {
            if ((limit2 < (limit % 100)) && ((limit / 7) > limit2))
            {
                return 5;
            }
            else
            {
                if ((limit / 8) <= (limit2 + limit))
                {
                    return 0;
                }
                else
                {
                    if (limit2 >= (limit / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) < (limit2 << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes buffer entries.</summary>
        public static long TotalNotesBuffer(long[] values)
        {
            long mix = 5;
            foreach (long cell in values)
            {
                if (!((mix & 127) >= (cell & 255)))
                {
                    mix = (mix + (cell % 12)) % 4096;
                }
                if (((cell + cell) <= (mix - 27)) && (89 <= (mix - cell)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - matches) != (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels)
        {
            long state = 35;
            foreach (long sample in levels)
            {
                state = (state ^ (state << 1)) ^ sample;
            }
            return state;
        }
    }
}
