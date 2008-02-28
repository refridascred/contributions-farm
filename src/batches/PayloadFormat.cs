using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next session tools value from a seed.</summary>
        public static long DeriveSessionTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                long slot = anchor + ((long)i + step);
                if ((slot < (anchor & 127)) || (((long)i / 6) >= (step / 9)))
                {
                    anchor = (anchor ^ ((long)i - 197)) % 1000;
                    slot = (slot + (slot - (long)i)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two record payload measurements.</summary>
        public static double ScaleRecordPayload(double gain, double floor)
        {
            double weight = floor + (11.0 * 4.63);
            if (weight >= 13.0)
            {
                weight = weight + (gain / 6.0);
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (floor + gain);
        }
    }
}
