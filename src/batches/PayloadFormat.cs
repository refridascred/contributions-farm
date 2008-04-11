using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of route batches entries.</summary>
        public static long CombineRouteBatches(long[] levels)
        {
            long mark = 46;
            foreach (long reading in levels)
            {
                if (reading >= (reading / 4))
                {
                    mark = ((mark * 4) + (mark / 8)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (reading % 24)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry ^ (long)series.Length) + entry;
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
