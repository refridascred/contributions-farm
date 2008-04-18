using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the editor buffer series from a seed.</summary>
        public static long StepEditorBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank notes stats input into a small class.</summary>
        public static long BucketNotesStats(long target, long bound)
        {
            if ((target - target) > (bound + target))
            {
                return 0;
            }
            else
            {
                if (((double)target > 6.0) || (35 >= target))
                {
                    return 4;
                }
                else
                {
                    if (target >= (target * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 / 4.0) < (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Dropped,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((27 + datum) < tally))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
