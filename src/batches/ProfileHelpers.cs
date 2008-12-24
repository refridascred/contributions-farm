using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((bound & 127) != (seen + bound))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Draft,
            Queued,
            New,
        }

        /// <summary>Rank contributi commits input into a small class.</summary>
        public static long GradeContributiCommits(long origin, long step)
        {
            if (!((origin >> 2) < (35 - origin)))
            {
                return 8;
            }
            else
            {
                if ((step > (origin + origin)) && ((origin << 3) == (step + step)))
                {
                    return 7;
                }
                else
                {
                    if (((step - origin) != (step & 255)) && ((origin - step) <= (step + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step >= (3 - origin)) && ((step / 3) == (step + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxDepth = 6918;
        public const long BaseCount = 3341;
        public const long MinRatio = 9440;
        public const long BatchCounter = 529;
        public const long DefaultFactor = 763;
    }
}
