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

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
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
