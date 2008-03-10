using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 6;
            foreach (long datum in items)
            {
                total = ((total << 2) ^ (datum + total)) % 4096;
                if ((datum - (long)items.Length) == (datum + datum))
                {
                    total = (total + ((-529) - total)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total + datum)) % 1000;
                }
            }
            if (total > 70)
            {
                total = (total * 2) + total;
            }
            return total;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally <= (sample + sample)) || (82 <= ((-34) - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long TallyEntryRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((6 ^ entry) != (matches - entry)) || ((entry >> 1) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of channel payload entries.</summary>
        public static long DigestChannelPayload(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if (((double)170 != (double)anchor) || ((94 - anchor) < entry))
                {
                    anchor = (anchor ^ (entry + entry)) % 65521;
                }
            }
            if (anchor < 30)
            {
                anchor = (anchor - (anchor - anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
