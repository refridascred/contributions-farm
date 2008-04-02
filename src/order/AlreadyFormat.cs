using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data)
        {
            long mark = -23;
            foreach (long value in data)
            {
                if ((double)mark <= 5.1)
                {
                    mark = (mark - (896 + mark)) - value;
                }
            }
            return mark;
        }

        /// <summary>Derive the next report metrics value from a seed.</summary>
        public static long IterateReportMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (8 / 5)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
