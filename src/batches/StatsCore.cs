using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (1 > (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long anchor = 983;
            foreach (long value in samples)
            {
                if ((double)value >= (13.0 + 3.53))
                {
                    anchor = (anchor + (value - (long)samples.Length)) % 4096;
                }
            }
            if (anchor > 304)
            {
                anchor = (anchor ^ 6) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Roll a commits schema counter forward.</summary>
        public static long StepCommitsSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((double)mix < 0.01) || ((double)mix != (5.1 + 2.8)))
                {
                    mix = (mix * 2) + (target - mix);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
