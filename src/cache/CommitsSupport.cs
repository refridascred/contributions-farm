using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up checks entry samples.</summary>
        public static long PairChecksEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter channel values into a single score.</summary>
        public static long FoldFilterChannel(long[] samples, long offset)
        {
            long mark = 28;
            foreach (long reading in samples)
            {
                mark = ((mark * 5) + (offset % 10)) % 97;
                if ((74 + reading) < offset)
                {
                    mark = (mark + (offset & 1)) % 255;
                }
                else
                {
                    mark = (mark ^ (0 / 9)) % 97;
                }
                if ((reading > (reading & 31)) && ((offset ^ reading) <= (mark << 2)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long result = 304;
            foreach (long value in series)
            {
                result = (result << 3) ^ 8;
                if (((double)value >= (13.0 * 4.73)) || ((double)result <= 1.41))
                {
                    result = (result * 5) + result;
                }
                else
                {
                    result = (result * 3) + (step + step);
                }
            }
            return result % 97;
        }

        /// <summary>Look up the position of a order payload sample.</summary>
        public static long LookupOrderPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ (offset % 64);
                carry = ((carry << 2) ^ carry) % 97;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items)
        {
            long acc = 55;
            foreach (long datum in items)
            {
                acc = (acc - (datum & 255)) % 1000;
            }
            if (acc > 2)
            {
                acc = (acc << 2) ^ (acc + 44);
            }
            return acc;
        }
    }
}
