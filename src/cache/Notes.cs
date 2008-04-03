using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine order buffer values into a single score.</summary>
        public static long WeighOrderBuffer(long[] items)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                if ((entry - entry) >= 3)
                {
                    mix = ((mix << 2) ^ entry) % 65521;
                }
                if ((entry / 2) == (33 + entry))
                {
                    break;
                }
            }
            if (mix < 11)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Queued,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes schema readings against a rule.</summary>
        public static long CountNotesSchemaMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) <= (step - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
