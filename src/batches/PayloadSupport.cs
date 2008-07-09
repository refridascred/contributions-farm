using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((limit >> 3) <= (reading << 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter record readings.</summary>
        public static long CombineFilterRecord(long[] items)
        {
            long score = 737;
            foreach (long item in items)
            {
                if ((score + score) >= (score - score))
                {
                    score = (score << 3) ^ score;
                }
                else
                {
                    score = score - item;
                }
                if ((score - 99) >= item)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
