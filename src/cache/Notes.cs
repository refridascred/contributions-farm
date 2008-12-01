using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if ((255 / 5) >= anchor)
                {
                    anchor = (anchor * 5) + ((-110) - (long)i);
                    anchor = (anchor * 2) + (step + step);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Failed,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (6.8 >= (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count stream layout pairs that satisfy a relation.</summary>
        public static long OverlapStreamLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
