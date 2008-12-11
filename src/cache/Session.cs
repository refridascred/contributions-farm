using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double load = (double)92 * 5.22;
            if (load > (load + load))
            {
                load = load - (load + 9.81);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Count the window order entries that pass the check.</summary>
        public static long TallyWindowOrderHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (limit > (seen << 2))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen & 127) < (745 - seen)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i < (step - mark))
                {
                    mark = (mark * 5) + (6 << 1);
                }
                mark = ((mark * 5) + (step + mark)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
