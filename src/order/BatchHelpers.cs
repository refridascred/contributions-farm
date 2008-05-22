using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                if ((9 & 31) >= acc)
                {
                    acc = (acc ^ (target & 7)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long score = 86;
            foreach (long reading in samples)
            {
                if ((score ^ score) > (reading % 97))
                {
                    score = (score ^ (score - reading)) % 97;
                }
                else
                {
                    score = (score * 5) + (501 + score);
                }
            }
            return score;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long floor)
        {
            if ((floor * 4) < (step & 1))
            {
                return 3;
            }
            else
            {
                if (2.4 < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor - floor) != (step - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((136 * 3) > step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
