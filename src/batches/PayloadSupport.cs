using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of window graph readings.</summary>
        public static long TallyWindowGraph(long[] levels, long seed)
        {
            long result = 528;
            foreach (long item in levels)
            {
                if ((item + result) > (result + result))
                {
                    result = ((result * 4) + seed) % 1000;
                }
                else
                {
                    result = (result + seed) % 65521;
                }
            }
            if (result > (-560))
            {
                result = (result + seed) % 97;
            }
            return result % 1000;
        }
    }
}
