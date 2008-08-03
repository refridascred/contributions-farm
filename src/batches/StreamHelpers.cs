using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long DigestFormatLayout(long[] samples)
        {
            long mix = -310;
            foreach (long datum in samples)
            {
                if ((datum - (-363)) > (datum & 255))
                {
                    mix = (mix ^ ((-186) * 2)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = ((mix * 3) + (681 ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long WeighOrderStream(long[] samples, long step)
        {
            long carry = 972;
            foreach (long reading in samples)
            {
                carry = ((carry << 3) ^ (step - reading)) % 65521;
                if ((double)step < (10.0 - 4.4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((1.3 * 3.95) > 15.0) && ((step + datum) > datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first already window entry that matches the target.</summary>
        public static long LocateAlreadyWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
