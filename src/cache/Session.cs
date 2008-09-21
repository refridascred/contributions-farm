using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items, long target)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                sum = (((sum ^ sum) % 101) ^ reading) + target;
            }
            return sum % 97;
        }

        /// <summary>Locate a record tools reading by value.</summary>
        public static long LookupRecordToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session schema values into a single score.</summary>
        public static long ScoreSessionSchema(long[] items, long step)
        {
            long mark = 98;
            foreach (long item in items)
            {
                mark = (((mark + ((long)items.Length + mark)) % 97) + item) + step;
            }
            if (mark > 62)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 1000;
        }
    }
}
