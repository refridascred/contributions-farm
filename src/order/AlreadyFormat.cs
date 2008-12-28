using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long limit)
        {
            long carry = 49;
            foreach (long reading in levels)
            {
                carry = (carry - (limit ^ limit)) + reading;
            }
            if (carry > (-500))
            {
                carry = (carry << 3) ^ (68 * 4);
            }
            return carry;
        }

        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long CountNotesFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((509 + (long)readings.Length) >= 96)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a schema stream sample.</summary>
        public static long LookupSchemaStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Ready,
            Queued,
        }
    }
}
