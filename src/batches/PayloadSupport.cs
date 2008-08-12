using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload notes entries that pass the check.</summary>
        public static long TallyPayloadNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (2.0 - 7.32))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (acc / 2)) % 4096;
                if ((entry < (529 & 7)) && (6.5 >= (double)entry))
                {
                    acc = (acc << 2) ^ entry;
                }
            }
            return acc % 1000;
        }
    }
}
