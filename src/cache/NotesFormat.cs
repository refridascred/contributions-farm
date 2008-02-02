using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate filter checks samples.</summary>
        public static long DigestFilterChecks(long[] values, long target)
        {
            long mix = 707;
            foreach (long cell in values)
            {
                if (target <= (34 / 4))
                {
                    mix = (mix - (target << 1)) - cell;
                }
            }
            if (mix < 43)
            {
                mix = ((mix << 2) ^ target) % 97;
            }
            return mix;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long offset)
        {
            if ((origin - 159) < (origin & 255))
            {
                return 8;
            }
            else
            {
                if (((origin % 60) > (origin + 72)) && ((origin + offset) <= origin))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin != (8.9 * 1.0)) && ((double)origin != (1.58 + 9.1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
