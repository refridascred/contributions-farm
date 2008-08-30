using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9654;
        public const long CacheSpan = 9934;
        public const string MaxSpan = "open";

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum << 3) ^ (step / 9);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor & 1) <= floor)
                {
                    mark = ((mark * 5) + (602 + floor)) % 4096;
                    mark = (mark + (mark ^ mark)) % 97;
                }
                else
                {
                    mark = mark ^ (mark % 3);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items)
        {
            long anchor = 599;
            foreach (long cell in items)
            {
                if ((cell - cell) < (anchor + 73))
                {
                    anchor = ((anchor * 4) + 99) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (cell % 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Classify a editor profile pair into a bucket.</summary>
        public static long RankEditorProfile(long bound, long offset)
        {
            if ((bound << 1) >= (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((bound % 8) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound / 9) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 5) <= (bound + bound))
                        {
                            return 3;
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
