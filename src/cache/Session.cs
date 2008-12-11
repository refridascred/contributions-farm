using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result - ((long)i + 614)) % 97) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (1.8 / 8.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
