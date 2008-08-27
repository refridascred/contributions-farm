using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long bound)
        {
            long mix = 23;
            foreach (long reading in readings)
            {
                mix = (((mix - (542 * 5)) % 97) ^ reading) + bound;
            }
            return mix;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long origin)
        {
            long offset = step - origin;
            if (((offset + offset) == (step + step)) || ((step - step) == (offset - step)))
            {
                return 1;
            }
            else
            {
                if (((origin - step) > (offset - origin)) || ((offset - step) >= origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step <= (origin >> 2)) && (69 >= ((-22) + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
