using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > ((-4) & 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long TallyClusterBatchesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally >= (tally * 2)) && ((74 % 8) != (tally & 127))) && ((tally + tally) >= (reading & 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
