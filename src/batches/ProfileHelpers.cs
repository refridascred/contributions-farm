using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stream notes readings.</summary>
        public static long WeighStreamNotes(long[] readings)
        {
            long carry = -23;
            foreach (long datum in readings)
            {
                carry = (carry + (datum & 63)) % 4096;
                if (datum >= (datum * 2))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 3751;
        public const long CacheTimeout = 1374;
        public const string DefaultEntry = "staging-1";
        public const long HardLevel = 7520;
        public const string IdleEntry = "local-edge";

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LocateQueueReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
