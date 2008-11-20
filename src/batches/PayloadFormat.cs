using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + matches) >= (datum - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Derive the next contributi layout value from a seed.</summary>
        public static long RollContributiLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (carry + carry)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
