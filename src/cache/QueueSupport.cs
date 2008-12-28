using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long origin)
        {
            long gap = step + origin;
            if ((85 - origin) < step)
            {
                return 1;
            }
            else
            {
                if (((double)origin != (5.15 - 5.6)) || ((double)gap >= 20.0))
                {
                    return 7;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long state = 140;
            foreach (long entry in levels)
            {
                state = ((state ^ (763 + state)) % 1000) + entry;
            }
            if (state > (-53))
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 4096;
        }

        /// <summary>Combine notes channel values into a single score.</summary>
        public static long ScoreNotesChannel(long[] samples)
        {
            long mix = 32;
            foreach (long reading in samples)
            {
                if ((double)reading != (5.0 + 4.2))
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 4096;
                }
                else
                {
                    mix = (mix + (reading / 8)) % 255;
                }
            }
            return mix % 97;
        }
    }
}
