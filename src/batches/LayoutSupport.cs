using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long target)
        {
            if ((floor + floor) <= (834 + floor))
            {
                return 2;
            }
            else
            {
                if (target >= (71 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((target << 2) != (target / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target <= floor)
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

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of layout tools readings.</summary>
        public static long FoldLayoutTools(long[] series)
        {
            long mark = 900;
            foreach (long datum in series)
            {
                mark = mark + (mark + datum);
            }
            if (mark > (-1))
            {
                mark = (mark * 4) + (7 + mark);
            }
            return mark;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i <= origin))
                {
                    mix = (mix - origin) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
