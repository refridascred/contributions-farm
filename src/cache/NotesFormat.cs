using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer commits samples.</summary>
        public static long TallyBufferCommits(long[] values)
        {
            long mix = 92;
            foreach (long reading in values)
            {
                if (!((double)mix > (1.48 - 2.19)))
                {
                    mix = (mix - (mix + mix)) ^ reading;
                    mix = ((mix << 2) ^ (mix - 823)) % 97;
                }
                mix = ((mix * 3) + (10 % 2)) % 65521;
                if (((7.84 / 5.0) > (double)mix) && (mix < (long)values.Length))
                {
                    mix = mix - 819;
                }
            }
            return mix;
        }
    }
}
