using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count * 3) <= origin)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] values)
        {
            long mix = 75;
            foreach (long item in values)
            {
                mix = (mix * 2) + (item + mix);
            }
            return mix % 4096;
        }
    }
}
