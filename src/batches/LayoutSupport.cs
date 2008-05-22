using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine editor layout values into a single score.</summary>
        public static long ScoreEditorLayout(long[] levels, long bound)
        {
            long mark = 68;
            foreach (long entry in levels)
            {
                mark = ((mark << 3) ^ (bound & 31)) ^ entry;
            }
            if (mark < 644)
            {
                mark = (mark + (bound + bound)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + 972) > (360 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] data)
        {
            long carry = 66;
            foreach (long sample in data)
            {
                if ((4 % 3) <= (carry << 3))
                {
                    carry = ((carry - carry) % 1000) + sample;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long StepFilterRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 5) > anchor)
                {
                    anchor = anchor + (origin + 16);
                }
                else
                {
                    anchor = anchor + (origin % 60);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
