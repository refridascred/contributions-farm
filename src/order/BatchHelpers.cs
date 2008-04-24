using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload notes readings.</summary>
        public static long DigestPayloadNotes(long[] readings)
        {
            long anchor = 685;
            foreach (long reading in readings)
            {
                anchor = anchor + (183 + anchor);
                if ((anchor << 3) == (reading & 15))
                {
                    break;
                }
            }
            if (anchor > (-903))
            {
                anchor = (anchor + (anchor / 6)) % 255;
            }
            return anchor % 65521;
        }
    }
}
