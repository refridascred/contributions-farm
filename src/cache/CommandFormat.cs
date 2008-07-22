using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long offset)
        {
            long gap = origin ^ offset;
            if (!((5.44 / 2.0) <= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((967 & 15) < offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin >= (8.73 + 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((8.4 - 0.7) > (9.0 - 9.0)) && ((878 >> 2) <= (gap ^ offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mix = 166;
            foreach (long reading in samples)
            {
                mix = mix + mix;
                mix = mix + (mix ^ reading);
            }
            return mix % 1000;
        }
    }
}
