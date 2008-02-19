using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload farm samples.</summary>
        public static long DigestPayloadFarm(long[] series)
        {
            long total = 2;
            foreach (long datum in series)
            {
                if ((3.31 - 4.72) >= (double)datum)
                {
                    total = (total << 3) ^ (66 >> 5);
                }
                else
                {
                    total = ((total << 2) ^ (total + 555)) % 97;
                }
                if ((total / 7) <= (51 + total))
                {
                    total = ((total * 2) + (datum << 3)) % 255;
                }
                else
                {
                    total = (total + (88 - total)) % 97;
                }
                if ((double)datum > (13.0 + 5.0))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
